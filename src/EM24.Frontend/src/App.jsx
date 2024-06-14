import { BrowserRouter, Routes, Route } from "react-router-dom";
import Header from './components/nav/Header';
import GameOverview from "./views/GameOverview";
import PlayerOverview from "./views/PlayerOverview";
import Frontpage from "./views/Frontpage";


const App = () => {

  return (
    <BrowserRouter>
      <Header />
      <Routes>
        <Route path="/" element={<Frontpage />}></Route>
        <Route path="/matches" element={<GameOverview />} />
        <Route path="/players" element={<PlayerOverview />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;