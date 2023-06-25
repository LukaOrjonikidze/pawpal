import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PawpalsComponent } from './pawpals.component';

describe('PawpalsComponent', () => {
  let component: PawpalsComponent;
  let fixture: ComponentFixture<PawpalsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PawpalsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PawpalsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
