@matplotlib inline
import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
import seaborn as sns
appointment_df= pd.read_csv('/Users/lubnaalhenaki/Downloads/noshowappointments.csv')
def time_series_by_country(country):
    corona_by_day_ser = corona[corona['Countries']==country].sort_values(by=['Year','Month','Day']).reset_index(drop=True)
    x = corona_by_day_ser.index
    y = corona_by_day_ser[['Deaths','Cases']]

    max_deaths_v = y['Deaths'].max()
    max_deaths_i = corona_by_day_ser['Deaths'].idxmax()

    max_cases_v =  y['Cases'].max()
    max_cases_i = corona_by_day_ser['Cases'].idxmax()

    fig = plt.figure()
    ax = fig.add_axes([.1,.1,1,1])

    ax.set_xlabel('Over time')
    ax.set_ylabel('Total of Deaths & Cases')
    ax.set_title('Sum of global deaths & cases over the time')
    ax.set_xticklabels(' ')

    ax.annotate('Max Deaths \n {} deaths'.format(max_deaths_v),xy=(max_deaths_i,max_deaths_v),xytext=( int(max_deaths_i)+5  ,int(max_deaths_v) + 50),
               arrowprops=dict(facecolor='red',shrink=0.05))

    ax.annotate('Max Cases \n {} cases'.format(max_cases_v) ,xy=(max_cases_i,max_cases_v),xytext=( int(max_cases_i)+5  ,int(max_cases_v) + 50),
               arrowprops=dict(facecolor='red',shrink=0.05))

    ax.plot(x,y)
        corona_by_day_ser = corona[corona['Countries']==country].sort_values(by=['Year','Month','Day']).reset_index(drop=True) #.sort_values(by=['Deaths']).reset_index(drop=True)
    x = corona_by_day_ser.index
    y = corona_by_day_ser[['Deaths','Cases']]
     max_deaths_v = y['Deaths'].max()
    max_deaths_i = corona_by_day_ser['Deaths'].idxmax()

    max_cases_v =  y['Cases'].max()
    max_cases_i = corona_by_day_ser['Cases'].idxmax()
        fig = plt.figure()
    ax = fig.add_axes([.1,.1,1,1])

    ax.set_xlabel('Over time')
    ax.set_ylabel('Total of Deaths & Cases')
    ax.set_title('Sum of global deaths & cases over the time')
    ax.set_xticklabels(' ')

    ax.annotate('Max Deaths \n {} deaths'.format(max_deaths_v),xy=(max_deaths_i,max_deaths_v),xytext=( int(max_deaths_i)+5  ,int(max_deaths_v) + 50),
               arrowprops=dict(facecolor='red',shrink=0.05))

    ax.annotate('Max Cases \n {} cases'.format(max_cases_v) ,xy=(max_cases_i,max_cases_v),xytext=( int(max_cases_i)+5  ,int(max_cases_v) + 50),
               arrowprops=dict(facecolor='red',shrink=0.05))

    ax.plot(x,y)
    time_series_by_country('China')