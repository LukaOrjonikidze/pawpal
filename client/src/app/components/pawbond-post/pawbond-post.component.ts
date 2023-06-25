import { Component, Input } from '@angular/core';
import { PawBondPost } from 'src/app/shared/models/pawbond-post.model';

@Component({
  selector: 'app-pawbond-post',
  templateUrl: './pawbond-post.component.html',
  styleUrls: ['./pawbond-post.component.sass']
})
export class PawpalComponent {
  @Input() pawbondPost: PawBondPost;

  constructor() {
    this.pawbondPost = new PawBondPost();
  }
}
