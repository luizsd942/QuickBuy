import { Component } from "@angular/core";

@Component({
  selector: "app-produto",
  template: "<html><body>{{ obterNome() }}</body></html>"
})
export class ProdutoComponent {
  //id: number;
  public nome: string;
  //preco: number;
  public liberadoParaVenda: boolean;

  public obterNome() {
    return "Teste Produto por Componente";
  }
}
