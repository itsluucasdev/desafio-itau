import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CotacaoDetailsComponent } from './cotacao-details/cotacao-details.component';

@NgModule({
  declarations: [
    AppComponent,
    CotacaoDetailsComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
