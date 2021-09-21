import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  public eventosfiltrados: any=[];

  widthImg: number = 150;
  marginImg: number = 5;
  mostrarImg: boolean = true;
  private _filtroList: string = '';


  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void{
    this.http.get('https://localhost:5001/api/Evento').subscribe(
      response => {
        this.eventos = response;
        this.eventosfiltrados =response;
      },
      error => console.log(error)
    );
  }

  showImage(){
    this.mostrarImg = !this.mostrarImg;
  }

  public get filtroLista(){
    return this._filtroList;
  }
  public set filtroLista(value : string){
    this._filtroList = value
    this.eventosfiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
  }

  filtrarEventos(filtraPro: string): any{
    filtraPro = filtraPro.toLowerCase();
    return this.eventos.filter(
      (e:{tema:string; local:string}) => e.tema.toLowerCase().indexOf(filtraPro) !== -1 ||
      e.local.toLowerCase().indexOf(filtraPro) !== -1
    );
  }

}
