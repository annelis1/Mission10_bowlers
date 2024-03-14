import { useEffect, useState } from 'react';
import { Bowler } from '../Type/Bowler';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5005/Bowler');
      const f = await rsp.json();
      setBowlerData(f);
    };
    fetchBowlerData();
  }, []);

  const filteredBowlers = bowlerData.filter(
    (b) => b.team.teamName === 'Marlins' || b.team.teamName === 'Sharks',
  );

  return (
    <div>
      <h4 className="text-center mt-4">Bowler Information</h4>
      <div style={{ padding: '0 8px' }}>
        <table className="table table-bordered table-striped">
          <thead>
            <tr>
              <th>First Name</th>
              <th>Middle Initial</th>
              <th>Last Name</th>
              <th>Team Name</th>
              <th>Address</th>
              <th>City</th>
              <th>State</th>
              <th>Zip</th>
              <th>Phone Number</th>
            </tr>
          </thead>
          <tbody>
            {filteredBowlers.map((b) => (
              <tr key={b.bowlerID}>
                <td>{b.bowlerFirstName}</td>
                <td>{b.bowlerMiddleInit}</td>
                <td>{b.bowlerLastName}</td>
                <td>{b.team.teamName}</td>
                <td>{b.bowlerAddress}</td>
                <td>{b.bowlerCity}</td>
                <td>{b.bowlerState}</td>
                <td>{b.bowlerZip}</td>
                <td>{b.bowlerPhoneNumber}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default BowlerList;
