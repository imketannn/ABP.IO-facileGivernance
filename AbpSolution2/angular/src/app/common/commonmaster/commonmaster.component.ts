import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

@Component({
  selector: "app-commonmaster",
  templateUrl: "./commonmaster.component.html",
})
export class CommonmasterComponent  {
  constructor(private router: Router) {}


  commonMaster(menuname): void {
    this.router.navigate(["/common/" + menuname]);
  }
}
