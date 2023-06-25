import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { HomeComponent } from './pages/home/home.component';
import { PawpalsComponent } from './pages/pawpals/pawpals.component';
import { PawbondsComponent } from './pages/pawbonds/pawbonds.component';
import { ContactComponent } from './pages/contact/contact.component';
import { MyPawpalComponent } from './pages/my-pawpal/my-pawpal.component';
import { PageNotFoundComponent } from './pages/page-not-found/page-not-found.component';
import { PawpalComponent } from './components/pawbond-post/pawbond-post.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    PawpalsComponent,
    PawbondsComponent,
    ContactComponent,
    MyPawpalComponent,
    PageNotFoundComponent,
    PawpalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
