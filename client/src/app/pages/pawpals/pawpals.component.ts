import { Component, OnInit } from '@angular/core';
import { PawBondPost } from '../../shared/models/pawbond-post.model';
import { DUMMY_PAWPALS } from '../../shared/dummy-data/DUMMY_ITEMS';

@Component({
  selector: 'app-pawpals',
  templateUrl: './pawpals.component.html',
  styleUrls: ['./pawpals.component.sass']
})
export class PawpalsComponent implements OnInit {
  public pawbondPosts?: PawBondPost[];

  constructor() {
    this.pawbondPosts = DUMMY_PAWPALS;
  }

  ngOnInit(): void {

  }
}
