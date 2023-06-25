import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PawpalsComponent } from './pages/pawpals/pawpals.component';
import { HomeComponent } from './pages/home/home.component';
import { PawbondsComponent } from './pages/pawbonds/pawbonds.component';
import { ContactComponent } from './pages/contact/contact.component';
import { MyPawpalComponent } from './pages/my-pawpal/my-pawpal.component';
import { PageNotFoundComponent } from './pages/page-not-found/page-not-found.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent},
  { path: 'pawpals', component: PawpalsComponent },
  { path: 'pawbonds', component: PawbondsComponent },
  { path: 'contact', component: ContactComponent },
  { path: 'my-pawpal', component: MyPawpalComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
