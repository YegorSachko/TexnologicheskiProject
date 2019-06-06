import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import { UserComponent } from './users/user/user.component';
import { UserListComponent } from './users/user-list/user-list.component';
import { UsersComponent } from './users/users.component';
import { UserService } from './shared/user.service';
import{HttpClientModule}from "@angular/common/http";
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {ToastrModule} from 'ngx-toastr';
import { NavMenuComponent } from './menu/nav-menu/nav-menu.component';
import { RatingComponent } from './menu/rating/rating.component';
import { InfoComponent } from './menu/info/info.component';
import { AuctionComponent } from './menu/auction/auction.component';
import { RouterModule } from '@angular/router';
import { SignInComponent } from './menu/sign-in/sign-in.component';
import { BotMenuComponent } from './menu/bot-menu/bot-menu.component';
import { LotsComponent } from './lot/lots/lots.component';

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    UserListComponent,
    UsersComponent,
    NavMenuComponent,
    RatingComponent,
    InfoComponent,
    AuctionComponent,
    SignInComponent,
    BotMenuComponent,
    LotsComponent,
   
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot([
      {path:'rating',component:RatingComponent},
      {path:'info',component:InfoComponent},
      {path:'',component:AuctionComponent},
      {path:'sign-in',component:SignInComponent},
     
    ]),
  ],
  providers: [UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
