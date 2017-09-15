using System;

namespace Examples
{
    public delegate void ShitDelegate();
    public delegate void ShitEvent(object sender, EventArgs args);

    class DelegateExamples
    {
        ShitDelegate OnShit;
        ShitDelegate OnCrap;

        event EventHandler OnShitEvent;

        public void SetUp()
        {
            OnShit += OnCrapOrShit;
            OnCrap += OnCrapOrShit;

            OnShitEvent += OnShitEventHandler;

            OnShit?.Invoke();

            var val = null ?? "asd" ?? "" ?? "";

            if (OnShit != null)
                OnShit();

            OnShit -= OnCrapOrShit;
        }

        public void OnCrapOrShit()
        {

        }

        public void OnShitEventHandler(object sender, EventArgs args)
        {

        }
    }
}
