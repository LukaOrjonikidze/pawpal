import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyPawpalComponent } from './my-pawpal.component';

describe('MyPawpalComponent', () => {
  let component: MyPawpalComponent;
  let fixture: ComponentFixture<MyPawpalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MyPawpalComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MyPawpalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
