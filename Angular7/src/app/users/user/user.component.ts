import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/shared/user.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styles: []
})
export class UserComponent implements OnInit {
  
  constructor(private service:UserService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?:NgForm){
    if(form!=null)
    form.resetForm();
    this.service.formData = {
      UserId:0,
      Login:'',
      born:'',
      Country:''
    }
  }
  onSubmit(form:NgForm){
    this.service.PostUser(form.value).subscribe(res=>{this.resetForm(form);},err =>{console.log(err)})
  }
}
