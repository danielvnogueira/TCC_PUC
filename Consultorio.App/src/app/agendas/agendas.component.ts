import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-agendas',
  templateUrl: './agendas.component.html',
  styleUrls: ['./agendas.component.css']
})
export class AgendasComponent implements OnInit {

  _filtroLista: string; //encapsulamento
  get filtroLista(): string {
    return this._filtroLista;
  }
  set filtroLista(value: string) {
    this._filtroLista = value;
    this.agendasFiltradas = this.filtroLista ? this.filtrarAgendas(this.filtroLista) : this.agendas;
  }

  agendasFiltradas: any = [];
  agendas: any = [];
  imagemLargura = 50;
  imagemMargem = 5;
  mostrarImagem = false;
  

  constructor(private http: HttpClient) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.getAgendas();
  }

  filtrarAgendas(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.agendas.filter(
      agenda => agenda.nomePaciente.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );

  }
  alternarImagem(){
    this.mostrarImagem = !this.mostrarImagem;
  }

  // tslint:disable-next-line: typedef
  // requisição ajax
  getAgendas() {
    this.http.get('http://localhost:5000/api/values').subscribe(response => {
      this.agendas = response;
      console.log(response);
    }, error => {
      console.log(error);
    }
    );
  }

}
