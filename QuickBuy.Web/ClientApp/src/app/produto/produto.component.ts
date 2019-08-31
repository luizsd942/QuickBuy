import { Component } from "@angular/core";

@Component({
  selector: "app-produto",
  templateUrl: "produto.component.html"
})
export class ProdutoComponent {
  //id: number;
  public nome: string;
  //preco: number;
  public liberadoParaVenda: boolean;

  public obterNome() {
    return "Teste Produto por Componente";
  }

  enviar() {
    alert('Teste');
  }

}
