import { TestBed } from '@angular/core/testing';

import { RestaurantServicesService } from './restaurant-services.service';

describe('RestaurantServicesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RestaurantServicesService = TestBed.get(RestaurantServicesService);
    expect(service).toBeTruthy();
  });
});
