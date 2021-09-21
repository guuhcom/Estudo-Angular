import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PlalestrantesComponent } from './plalestrantes.component';

describe('PlalestrantesComponent', () => {
  let component: PlalestrantesComponent;
  let fixture: ComponentFixture<PlalestrantesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PlalestrantesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PlalestrantesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
