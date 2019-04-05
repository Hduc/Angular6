import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VosRendezVousComponent } from './vos-rendez-vous.component';

describe('VosRendezVousComponent', () => {
  let component: VosRendezVousComponent;
  let fixture: ComponentFixture<VosRendezVousComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VosRendezVousComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VosRendezVousComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
