import { Component, OnInit } from '@angular/core';
import { AppService } from './app.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';//this is added for form
 

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Demo_Getting_Started with Services ';
  /**
   * Here we are importing service as a argument in the contrustor as below
   */
  constructor(  private appService: AppService ) {}
     
      userForm = new FormGroup({
        firstName: new FormControl('',  Validators.required),
        lastName: new  FormControl('', Validators.required),
        email : new    FormControl('',  Validators.required)
      });
      users : any[]  = [];
 
      userCount = 0;
     
      ngOnInit(): void {}
     
      onSubmit() {
        console.log(this.userForm.value);
        const data = this.appService.addUser(this.userForm.value);
        this.userCount = this.userCount + 1;
        //this.userCount.reset();
      }
     
      getAllUser() {
        this.users = this.appService.getuser();
      }
      }
    
    