import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { CompanyDataFormComponent } from './company-data-form/company-data-form.component';
import { ApplicationDataFormComponent } from './application-data-form/application-data-form.component';

@NgModule({
  declarations: [
    AppComponent,
    CompanyDataFormComponent,
    ApplicationDataFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
