import { Component, OnInit } from '@angular/core';
import { PawBondPost } from '../../shared/models/pawbond-post.model';
import { DUMMY_PAWPALS } from '../../shared/dummy-data/DUMMY_ITEMS';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-pawpals',
  templateUrl: './pawpals.component.html',
  styleUrls: ['./pawpals.component.sass']
})
export class PawpalsComponent implements OnInit {
  public pawbondPosts?: PawBondPost[];

  constructor(private apiService: ApiService) {
  }

  ngOnInit(): void {
    this.getPawbondPosts();
  }
  getPawbondPosts(): void {
    this.apiService.get('api/PawbondPosts').subscribe((data) => {
      console.log(data)
      this.pawbondPosts = data.$values;
    });
  }
}
