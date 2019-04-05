import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VosInformationComponent } from './vos-information.component';

describe('VosInformationComponent', () => {
  let component: VosInformationComponent;
  let fixture: ComponentFixture<VosInformationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VosInformationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VosInformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
