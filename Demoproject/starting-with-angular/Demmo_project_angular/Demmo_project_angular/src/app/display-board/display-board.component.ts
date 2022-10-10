import { Component, OnInit , Input,Output, EventEmitter} from '@angular/core';

@Component({
  selector: 'app-display-board',
  templateUrl: './display-board.component.html',
  styleUrls: ['./display-board.component.css']
})
export class DisplayBoardComponent implements OnInit {

  constructor() { }
  @Input()userCount = 0;
  @Output()getUserEvent = new EventEmitter();

  ngOnInit(): void {
    getAllUser();{
      this.getUserEvent.emit('get all users');
    }
  }

}
function getAllUser() {
  throw new Error('Function not implemented.');
}

