import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { StudentService } from './student.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  today: number =Date.now();
  salary:number = 12345.00;
  students: any[]= []
  pagetitle :string | undefined;
 private _studentService : StudentService;
  student: any[] = [];
 /**
  * 
  * 
  */
  constructor ( studentService: StudentService){
    this._studentService = studentService;
  }
  
  ngOnit(){
    this.student =this._studentService.getStudents();

this.pagetitle =this._studentService.getTitle();[
    
    {
      ID:'101'  ,Name:'Priyanka Sharma' ,DOB:'January/24/2022', Gender: 'Female', CorseFee:1000
    },
       {
        ID:'102'  ,Name:'Priyansh Awasthi' ,DOB:'June/14/2022', Gender: 'Male', CorseFee:1800
      },

       

{
      ID:'103' , Name:'Shruti Pandey' ,DOB:'June/05/2002', Gender: 'Female', CorseFee:1500
    },
       {
        ID:'104' , Name:'Sumati Awasthi' ,DOB:'May/07/1994', Gender: 'Female', CorseFee:1900
      },

       
       {
        ID:'105' , Name:'Shivam Pandey' ,DOB:'02/02/2022', Gender: 'Male', CorseFee:1000
      }
     
    ];
  }
  // constructor(private router: Router){ }

  // GetStudent()
  // {
  //   this.router.navigate([ '/studentlink']);

  // }
  // GetStudentDetails()
  // {
  //   this.router.navigate(['/studentdetailslink']);
  // }
  // GetLogin()
  // {
  //   this.router.navigate(['/loginlink']);

      
