import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RestaurantcomponentComponent } from './restaurantcomponent.component';

describe('RestaurantcomponentComponent', () => {
  let component: RestaurantcomponentComponent;
  let fixture: ComponentFixture<RestaurantcomponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RestaurantcomponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RestaurantcomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
