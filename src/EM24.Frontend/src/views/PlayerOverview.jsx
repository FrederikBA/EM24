import playerService from "../services/playerService";
import { Table } from 'react-bootstrap';
import { useState, useEffect } from 'react';

const PlayerOverview = () => {
    const [players, setPlayers] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await playerService.getAllPlayers();
                setPlayers(response);
            } catch (error) {
                console.log(error);
            }
        };

        fetchData();
    }, []);

    return (
        <div className="center-container">
            <Table className="center-table">
                <thead>
                    <tr>
                        <th></th>
                        <th className="center-content">Navn</th>
                        <th className="center-content">Point</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {players.map(player => (
                        <tr key={player.id}>
                            <td></td>
                            <td className="center-content"><span className="match-number">{player.name}</span></td>
                            <td className="center-content"><span className="score">{player.points}</span></td>
                            <td></td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </div>
    )
}

export default PlayerOverview;
