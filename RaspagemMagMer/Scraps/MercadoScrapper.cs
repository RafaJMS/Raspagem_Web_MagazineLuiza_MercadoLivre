﻿using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using RaspagemMagMer.Models;
using System;
using System.Reflection.Metadata;
using RaspagemMagMer.Operations;

namespace RaspagemMagMer.Scraps
{
    public class MercadoLivreScraper
    {
        public string ObterPreco(string descricaoProduto, int idProduto)
        {
            string[] response = new string[3];
            
            string url = $"https://lista.mercadolivre.com.br/{descricaoProduto}";

            try
            {
                
                HtmlWeb web = new HtmlWeb();

                
                HtmlDocument document = web.Load(url);

                        
                HtmlNode firstProductPriceNode = document.DocumentNode.SelectSingleNode("//span[@class='andes-money-amount__fraction']");
                
                
                if (firstProductPriceNode != null)
                {
                    
                    string firstProductPrice = firstProductPriceNode.InnerText.Trim();

                    LogRegister.RegistrarLog(DateTime.Now, "WebScraping - Mercado Livre", "Sucesso", idProduto);

                    return firstProductPrice;
                }
                else
                {
                    Console.WriteLine("Preço não encontrado.");

                    LogRegister.RegistrarLog(DateTime.Now, "WebScraping - Mercado Livre", "Preço não encontrado", idProduto);

                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao acessar a página: {ex.Message}");

                LogRegister.RegistrarLog(DateTime.Now, "Web Scraping - Mercado Livre", $"Erro: {ex.Message}", idProduto);

                return null;
            }
        }

        public string ObterNome(string descricaoProduto)
        {
            string url = $"https://lista.mercadolivre.com.br/{descricaoProduto}";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);
            HtmlNode firstProductPriceName = document.DocumentNode.SelectSingleNode("//h2[@class='ui-search-item__title']");

            if (firstProductPriceName != null)
            {
                string firstProductName = firstProductPriceName.InnerText.Trim();
                return firstProductName;
            }
            else
            {
                return null;
            }
        }

        public string ObterLink(string descricaoProduto)
        {
            string url = ($"https://lista.mercadolivre.com.br/{descricaoProduto.Replace(' ', '+')}");
            return url;
        }
    }
}