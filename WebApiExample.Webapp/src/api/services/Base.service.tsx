import { HttpConfig } from '../constants/Http.config';

const { basePath, getHeader, postHeader, deleteHeader } = HttpConfig;
const BaseService = {

    httpGet: async (controller: any): Promise<any> => {
        const response = await fetch(`${basePath}/${controller}/get`, getHeader );
        return  response.json();
    },
    httpPost: async (controller: any, id : number): Promise<any> => {
        const response = await fetch(`${basePath}/${controller}`, postHeader(id));
        return  await response?.json() ?? "";
    },
    httpDelete: async (controller: any,  id : number): Promise<any> => {
        debugger
        const response = await fetch(`${basePath}/${controller}/${id}`, deleteHeader(id));
        return  await response?.json() ?? "";
    }
}

export default BaseService;