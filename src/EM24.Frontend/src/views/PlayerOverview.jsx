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
        <div className="center">
            <Table>
                <thead>
                    <tr>
                        <th></th>
                        <th className="table-header">Navn</th>
                        <th className="table-header">Point</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {players.map(player => (
                        <tr className="table-row" key={player.id}>
                            <td></td>
                            <td className="table-item player-table-item"><span className="match-number">{player.name}</span></td>
                            <td className="table-item player-table-item"><span className="score">{player.points}</span></td>
                            <td></td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </div>
    )
}

export default PlayerOverview;
