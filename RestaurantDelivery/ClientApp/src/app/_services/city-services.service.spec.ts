import { TestBed } from '@angular/core/testing';

import { CityServicesService } from './city-services.service';

describe('CityServicesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CityServicesService = TestBed.get(CityServicesService);
    expect(service).toBeTruthy();
  });
});
