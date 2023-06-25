import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PawbondsComponent } from './pawbonds.component';

describe('PawbondsComponent', () => {
  let component: PawbondsComponent;
  let fixture: ComponentFixture<PawbondsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PawbondsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PawbondsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
