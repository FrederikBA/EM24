import axios from "axios";
import apiUtils from "../utils/apiUtils";

const playerService = () => {
    const URL = apiUtils.getUrl();

    const getAllPlayers = async () => {
        try {
            const response = await axios.get(URL + '/players');
            return response.data;
        } catch (error) {
            throw new Error('Error fetching players');
        }
    };

    return {
        getAllPlayers
    };
};

export default playerService();