const URL = 'http://localhost:5177/api';

const api = () => {

    const getUrl = () => {
        return URL;
    }

    return {
        getUrl
    }
}

export default api();