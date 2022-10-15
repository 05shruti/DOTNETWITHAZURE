import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-view-all-products-by-date',
  templateUrl: './view-all-products-by-date.component.html',
  styleUrls: ['./view-all-products-by-date.component.css']
})
export class ViewAllProductsByDateComponent implements OnInit {
  searchDate = '';
  activatedRoute: any;
  constructor() { }

  ngOnInit(): void {
    this.activatedRoute.queryParams.subscribe((data: { date: string; }) => {
      this.searchDate = data.date;
    });
  }

}
