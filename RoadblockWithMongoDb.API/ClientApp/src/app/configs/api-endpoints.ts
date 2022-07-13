import { environment } from "src/environments/environment";

export const baseUrl = environment.apiUrl + '/api';

export const carServiceUrl = baseUrl + '/cars/';