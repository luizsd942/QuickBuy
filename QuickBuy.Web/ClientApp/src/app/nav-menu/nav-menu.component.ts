import { Component } from '@angular/core';
import { Route } from '@angular/compiler/src/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private route:Router) {

  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  public usuarioAutenticado(): boolean {
    return sessionStorage.getItem("usuario-autenticado") == "1";
  }

  sair() {
    sessionStorage.setItem("usuario-autenticado","0");
    this.route.navigate(['/']);
  }
}
