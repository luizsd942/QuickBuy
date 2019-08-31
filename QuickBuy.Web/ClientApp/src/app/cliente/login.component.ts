import { Component } from "@angular/core";
import { Usuario } from "../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "login.component.html",
  styleUrls: ["login.component.css"]
})
export class LoginComponent {

  public usuario;
  public usuarioAutenticado: boolean;
  public nomes = ["Luiz", "Julia", "Joyce", "Rafael"];

  constructor() {
    this.usuario = new Usuario();
  }

  public login() {
    this.usuarioAutenticado = this.usuario.email === 'luizsd942@gmail.com' && this.usuario.senha === 'abc123';
  }


}
