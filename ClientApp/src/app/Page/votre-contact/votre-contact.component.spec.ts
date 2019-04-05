import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VotreContactComponent } from './votre-contact.component';

describe('VotreContactComponent', () => {
  let component: VotreContactComponent;
  let fixture: ComponentFixture<VotreContactComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VotreContactComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VotreContactComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
