import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { StudentDetailsComponent } from './student-details/student-details.component';
import { StudentComponent } from './student/student.component';


const routes: Routes = [
  {
path:'', redirectTo: 'loginlink' ,pathMatch:'full'
  },
  {
    path:'loginlink' , component:LoginComponent
  
   },


   {

   
    path:'studentlink' , component:StudentComponent},
   {

   
    path:'studentdetailslink' , component:StudentDetailsComponent}
  
   
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
