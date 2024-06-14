import gameService from "../services/gameService";
import { Table } from 'react-bootstrap';
import { useState, useEffect } from 'react';

const GameOverview = () => {
    const [games, setGames] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await gameService.getAllGames();
                setGames(response);
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
                        <th className="table-header">#</th>
                        <th className="table-header">Hold 1</th>
                        <th className="table-header table-product-name">Hold 2</th>
                        <th className="table-header table-producer">Resultat</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {games.map(game => (
                        <tr className="table-row" key={game.id}>
                            <td></td>
                            <td className="table-item"><span className="match-number">{game.id}</span></td>
                            <td className="table-item table-product-name">
                                <img src={`/flags/flag_${game.rightTeam}.svg`} alt="flag" className="flag" />
                                <span> </span><span className="country">{game.rightTeam}</span>
                            </td>
                            <td className="table-item table-product-name">
                                <img src={`/flags/flag_${game.leftTeam}.svg`} alt="flag" className="flag" />
                                <span> </span><span className="country">{game.leftTeam}</span>
                            </td>
                            <td className="table-item"><span className="score">{game.result}</span></td>
                            <td></td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </div>
    )
}

export default GameOverview;
