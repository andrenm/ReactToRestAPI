import BaseService from './Base.service';

const { httpGet,  httpPost , httpDelete } = BaseService;
const ConfigurationApiService = {

    getAll: async (ControllersConfig: any) => await httpGet(ControllersConfig).then((response) => {
        return response;
    }),

    updateById: async (ControllersConfig: any, id: number) => await httpPost(ControllersConfig, id).then((response) => {
        return response;
    }),

    deleteById: async (ControllersConfig: any, id: number) => await httpDelete(ControllersConfig, id).then((response) => {
        return response;
    })

}

export default ConfigurationApiService;