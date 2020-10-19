﻿using Pushenger.Core.Entities;
using Pushenger.Core.Utilities.Result;

namespace Pushenger.Core.Interfaces
{
    public interface ICompanyRepository
    {
        /// <summary>
        /// Bu eposta bilgisine ait aktif firma var mı kontrol etmek için kullanılır.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        IResult CheckEmail(string email);
        /// <summary>
        /// Firma ve yetkili kullanıcı eklemek için kullanılır.
        /// </summary>
        /// <param name="company"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        IResult Insert(Company company,User user);
    } 
}