import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VosRendezVousDetailComponent } from './vos-rendez-vous-detail.component';

describe('VosRendezVousDetailComponent', () => {
  let component: VosRendezVousDetailComponent;
  let fixture: ComponentFixture<VosRendezVousDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VosRendezVousDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VosRendezVousDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
