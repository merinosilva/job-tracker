import { Component, OnInit } from '@angular/core';
import { Guid } from 'guid-typescript';
import { Company } from '../model/company';
import { CompanyService } from '../services/company.service';

@Component({
  selector: 'app-company-data-form',
  templateUrl: './company-data-form.component.html',
  styleUrls: ['./company-data-form.component.css']
})
export class CompanyDataFormComponent implements OnInit {
  company: Company = {id:Guid.create().toString(), name:'Company Name', location:'Colombo, Sri Lanka', website:'http://test.com'};

  constructor(private service: CompanyService) { }

  ngOnInit(): void {
    this.service.listCompanies().subscribe(res => {console.log(res)});
  }

  onSaveCompany(){
    this.service.saveCompany(this.company);
  }

}
