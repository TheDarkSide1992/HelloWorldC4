import {Component, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {FormControl, Validators} from "@angular/forms";
import {firstValueFrom} from "rxjs";
import {MessageReturn} from "../Models/MessageReturn";

@Component({
  selector: 'app-home=',
  template: `
    <ion-select placeholder="Select Language" [formControl]="languageControl">
      <ion-select-option *ngFor="let language of languagelist">
        {{ language }}
      </ion-select-option>
    </ion-select>
    <p>{{this.greeting}} {{this.planet}}</p>
    <ion-button (click)="generateGreeting()">Generate greeting</ion-button>`,
  styleUrls: ['home.page.scss'],
  standalone: false,
})
export class HomePage implements OnInit {

  public languagelist: string[] = []
  greeting: string | undefined = ""
  planet: string | undefined = ""
  languageControl = new FormControl("",[Validators.required]);



  constructor(public http: HttpClient) { }

  ngOnInit(): void {
    setTimeout(() => {
      this.getLanguages()

    }, 2000)
    }

  async getLanguages()
  {
    const call = this.http.get<string[]>("http://language-api/getlanguage");
    this.languagelist = await firstValueFrom<string[]>(call)
  }

  generateGreeting() {
    this.getGreeting()
    this.getPlanet()
  }

  private async getPlanet() {
    const call = this.http.get<MessageReturn>("http://planet-api/planet/?language="+this.languageControl.value?.trim());
    const result = await firstValueFrom<MessageReturn>(call)
    this.planet = result.message
    }

  private async getGreeting() {
    const call = this.http.get<MessageReturn>("http://greeting-api/greetings/?language="+this.languageControl.value?.trim());
    const result = await firstValueFrom<MessageReturn>(call)
    this.greeting = result.message
  }
}
