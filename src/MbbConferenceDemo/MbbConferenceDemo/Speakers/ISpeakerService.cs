﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace MbbConferenceDemo.Speakers
{
    public interface ISpeakerService
    {
        Task<IList<Speaker>> GetSpeakersAsync();
        Task<IList<Speaker>> Search(string filter);
        Task<Speaker> GetSpeakerAsync(int id);
    }
}
