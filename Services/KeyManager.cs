using System.Threading.Tasks;
using WindowsInput.Events;


// Manages the actions of issuing keypresses
namespace ExternED.Services
{
    public class KeyManager
    {

        public async Task<bool> ProofOfConcept()
        {
            await WindowsInput.Simulate.Events()
                // Open Notepad
                .ClickChord(KeyCode.LWin, KeyCode.R).Wait(1000)
                .Click("notepad").Wait(1000)
                .Click(KeyCode.Return).Wait(1000)

                // POC Message
                .Click("Proof of Conceopt Test")
                .Click("Window will close in 3 seconds").Wait(3000)

                // Close Notepad
                .ClickChord(KeyCode.Alt, KeyCode.F4).Wait(1000)
                .Click(KeyCode.Tab, KeyCode.Return)

                // Go
                .Invoke();

            return true;
        }



    }
}
