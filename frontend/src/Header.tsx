import logo from './BowlerLogo.png';

function Header() {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-3">
        <img src={logo} className="logo" width="100" alt="logo" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">Marlins and Sharks Bowlers</h1>
      </div>
    </header>
  );
}
export default Header;
