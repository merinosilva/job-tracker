import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Company } from "../model/company";

@Injectable({providedIn: 'root'})
export class CompanyService{
    constructor(private http: HttpClient){}

    saveCompany(data: Company){
        this.http.post('http://localhost:5000/api/company/save', data).subscribe(res => {console.log(res)});
    }

    listCompanies(){
        return this.http.get('http://localhost:5000/api/company/list-all');
    }
}