import axios from "axios";
import apiUtils from "../utils/apiUtils";

const gameService = () => {
    const URL = apiUtils.getUrl();

    const getAllGames = async () => {
        try {
            const response = await axios.get(URL + '/games');
            return response.data;
        } catch (error) {
            throw new Error('Error fetching games');
        }
    };

    return {
        getAllGames
    };
};

export default gameService();