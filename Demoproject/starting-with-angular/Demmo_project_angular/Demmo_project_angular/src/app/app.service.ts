import { Injectable } from '@angular/core';
import { FormArrayName } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  constructor() {
    // console.log("This is an app service constructor in Action..!!");

  }
  
  users =[{
    firstname:'Shruti',
    lastname:'Pandey',
    email : 'shrutipandey9997@gmail.com'
  },{
    firstname :'Shivam',
    lastname : 'Pandey',
    email: 'shivampandey3@gmail.com'
    
  }];
  getuser(){ //displaying user
    return this.users;
  }
  addUser(user:any)//saving users
{
  return this.users.push(user);
}
  // TestMethod():String{
  //   return('Test method is executed'); //to test a service we will define a method in a service and inject in a component for testing
    
  }

