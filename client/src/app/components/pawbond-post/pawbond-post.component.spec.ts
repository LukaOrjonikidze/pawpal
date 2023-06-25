import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PawpalComponent } from './pawbond-post.component';

describe('PawpalComponent', () => {
  let component: PawpalComponent;
  let fixture: ComponentFixture<PawpalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PawpalComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PawpalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
