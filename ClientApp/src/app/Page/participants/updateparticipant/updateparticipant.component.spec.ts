import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateparticipantComponent } from './updateparticipant.component';

describe('UpdateparticipantComponent', () => {
  let component: UpdateparticipantComponent;
  let fixture: ComponentFixture<UpdateparticipantComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UpdateparticipantComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateparticipantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
