import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SliderlogoComponent } from './sliderlogo.component';

describe('SliderlogoComponent', () => {
  let component: SliderlogoComponent;
  let fixture: ComponentFixture<SliderlogoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SliderlogoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SliderlogoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
