import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CompanyDataFormComponent } from './company-data-form/company-data-form.component';

@NgModule({
  declarations: [
    AppComponent,
    CompanyDataFormComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
