import { Component, OnInit } from "@angular/core";
import { Usuario } from "../modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { state } from "@angular/animations";

@Component({
  selector: "app-login",
  templateUrl: "login.component.html",
  styleUrls: ["login.component.css"]
})
export class LoginComponent implements OnInit {


  public usuario;  
  public urlRetorno: "";

  constructor(private router: Router, private activedRoute: ActivatedRoute) {    
  }

  ngOnInit(): void {
    this.usuario = new Usuario();
    this.urlRetorno = this.activedRoute.snapshot.queryParams['returnUrl'];
  }

  public login() {
    if (this.usuario.email === 'luizsd942@gmail.com' && this.usuario.senha === 'abc123') {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.urlRetorno]);
    }

  }


}
