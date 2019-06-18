import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styles: []
})
export class LoginComponent implements OnInit {
formModel={
  Login1:'',
  Password1:'',
}
  constructor() { }

  ngOnInit() {
  }

}
