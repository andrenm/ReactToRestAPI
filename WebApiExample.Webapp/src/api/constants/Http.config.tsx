let header  = new Headers();
header.append( 'Content-Type', 'application/json');
header.append( 'Access-Control-Allow-Origin', '*');
header.append( 'Access-Control-Allow-Credentials', 'include');

export const HttpConfig = {
    basePath: "https://localhost:5001/api", // BackEnd project address, see also appsettings.json file
    getHeader: {
        method: 'GET',
        header
    },
    postHeader: (data: any) => {
        return {
            method: 'POST',
            header,
            body: JSON.stringify(data)
        }
    }, deleteHeader: (data: any) => {
        return {
            method: 'DELETE',
            header,

            body: JSON.stringify(data)
        }
    }

}