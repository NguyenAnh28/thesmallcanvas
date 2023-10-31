<?php /* Template Name: Home */ ?>
<?php
get_header();
?>
<main>
    <section class="box-banner">
        <div class="container">
            <div class="main_content">
                <?php $i == 1; ?>
                <?php while ( has_sub_field('list_1') ) : ?>
                <div class="picture_wrapper" data-aos="zoom-in"><a href="javascript:void(0)" data-tab="inf-<?= $i; ?>"><img src="<?php the_sub_field('image'); ?>" class="img-fluid w-100" alt="<?php the_sub_field('title'); ?>"></a></div>
                <?php $i++; ?>
                <?php endwhile; ?>
            </div>

            <div class="content-gallery">
                <div class="overlay"></div>
                <?php $j == 1; ?>
                <?php while ( has_sub_field('list_1') ) : ?>
                <div class="item-gallery" id="inf-<?= $j; ?>">
                    <div class="txt-info-gallery">
                        <h2>ABOUT PAINT</h2>
                        <div class="close-galley">
                            <a href="javascript:void(0)">
                                <svg width="42" height="42" viewBox="0 0 42 42" fill="none" xmlns="http://www.w3.org/2000/svg">
                                    <rect width="42" height="42" rx="21" fill="#EFEFEF"/>
                                    <g opacity="0.8">
                                        <path d="M27 15L15 27" stroke="#101010" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/>
                                        <path d="M15 15L27 27" stroke="#101010" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/>
                                    </g>
                                </svg>
                            </a>
                        </div>
                        <div class="avarta"><img src="<?php the_sub_field('image'); ?>" class="img-fluid w-100" alt="<?php the_sub_field('title'); ?>"></div>
                        <div class="info">
                            <h3><?php the_sub_field('title'); ?></h3>
                            <div class="desc">
                                <?php the_sub_field('description'); ?>
                            </div>
                        </div>
                    </div>
                </div>
                <?php $j++; ?>
                <?php endwhile; ?>
            </div>

            <div class="bottom-gallery">
                <h1 data-aos="fade-left"><?= nl2br(get_field('title2')); ?></h1>
                <div class="desc" data-aos="fade-right">
                    <svg width="13" height="48" viewBox="0 0 13 48" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <path d="M0 0H12.1319V5.32729H6.19955V42.6727H12.1319V48H0V0Z" fill="#181818"/>
                    </svg>
                    <p><?= nl2br(get_field('description')); ?></p>
                    <svg width="13" height="48" viewBox="0 0 13 48" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <path d="M13 0H0.868132V5.32729H6.80045V42.6727H0.868132V48H13V0Z" fill="#181818"/>
                    </svg>
                </div>
            </div>
        </div>
    </section>
    <section class="box-featured">
        <div class="container">
            <div class="content-featured">
                <div class="row">
                    <div class="col-md-6">
                        <div class="sidebar-feat">
                            <div class="title-feat" data-aos="fade-up">
                                <h2>
                                    <?= nl2br(get_field('title')); ?>
                                    <span><?= nl2br(get_field('subtitle')); ?></span>
                                </h2>
                            </div>
                            <div class="view-all" data-aos="fade-up">
                                <a href="<?php the_field('link2'); ?>">
                                    <span><?php the_field('button'); ?></span>
                                    <svg width="32" height="32" viewBox="0 0 32 32" fill="none" xmlns="http://www.w3.org/2000/svg">
                                        <path fill-rule="evenodd" clip-rule="evenodd" d="M16 5C9.92487 5 5 9.92487 5 16C5 22.0751 9.92487 27 16 27C22.0751 27 27 22.0751 27 16C27 9.92487 22.0751 5 16 5ZM3 16C3 8.8203 8.8203 3 16 3C23.1797 3 29 8.8203 29 16C29 23.1797 23.1797 29 16 29C8.8203 29 3 23.1797 3 16Z" fill="#181818"/>
                                        <path fill-rule="evenodd" clip-rule="evenodd" d="M16.0553 11.0554C16.4459 10.6649 17.079 10.6649 17.4696 11.0554L21.7071 15.2929C22.0976 15.6834 22.0976 16.3166 21.7071 16.7071L17.4696 20.9446C17.079 21.3351 16.4459 21.3351 16.0553 20.9446C15.6648 20.5541 15.6648 19.9209 16.0553 19.5304L19.5857 16L16.0553 12.4696C15.6648 12.0791 15.6648 11.4459 16.0553 11.0554Z" fill="#181818"/>
                                        <path fill-rule="evenodd" clip-rule="evenodd" d="M10 16C10 15.4477 10.4477 15 11 15H21C21.5523 15 22 15.4477 22 16C22 16.5523 21.5523 17 21 17H11C10.4477 17 10 16.5523 10 16Z" fill="#181818"/>
                                    </svg>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="list-feat">
                            <?php while ( has_sub_field('list') ) : ?>
                            <div class="item-feat">
                                <div class="avarta"><img src="<?php the_sub_field('image'); ?>" class="img-fluid w-100" alt="<?php the_sub_field('title'); ?>"></div>
                                <div class="info">
                                    <div class="desc-head">
                                        <h3><?php the_sub_field('title'); ?></h3>
                                        <div class="desc">
                                            <?= nl2br(get_sub_field('description')); ?>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <?php endwhile; ?>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="box-article">
        <div class="container">
            <div class="title text-center" data-aos="fade-up">
                <h2>MY ARTICLES</h2>
            </div>
            <div class="list-article" data-aos="fade-up">
                <div class="row">
                    <?php
                        $tax = array(
                            'post_type'     => 'post',
                            'orderby'       => 'ID', 
                            'posts_per_page' => 3,
                        );
                        $looptax = new WP_Query( $tax ); 

                        while ( $looptax->have_posts() ) : $looptax->the_post();
                        ?>
                        <div class="col-md-4">
                            <div class="item-article">
                                <div class="avarta"><a href="<?php the_permalink(); ?>"><img src="<?= the_post_thumbnail_url(); ?>" class="img-fluid w-100" alt="<?php the_title(); ?>"></a></div>
                                <div class="info">
                                    <div class="date"><?= get_the_date('d/m/Y'); ?></div>
                                    <h3><a href="<?php the_permalink(); ?>"><?php the_title(); ?></a></h3>
                                    <div class="desc">
                                        <?php the_excerpt(); ?>
                                    </div>
                                </div>
                            </div>
                        </div>
                    <?php
                        endwhile;
                        wp_reset_query(); 
                    ?>  
                </div>
                <div class="view-all">
                    <a href="<?php the_field('link'); ?>">
                        <span>VIEW ALL ARTICLES</span>
                        <svg width="32" height="32" viewBox="0 0 32 32" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <path fill-rule="evenodd" clip-rule="evenodd" d="M16 5C9.92487 5 5 9.92487 5 16C5 22.0751 9.92487 27 16 27C22.0751 27 27 22.0751 27 16C27 9.92487 22.0751 5 16 5ZM3 16C3 8.8203 8.8203 3 16 3C23.1797 3 29 8.8203 29 16C29 23.1797 23.1797 29 16 29C8.8203 29 3 23.1797 3 16Z" fill="#181818"/>
                            <path fill-rule="evenodd" clip-rule="evenodd" d="M16.0553 11.0554C16.4459 10.6649 17.079 10.6649 17.4696 11.0554L21.7071 15.2929C22.0976 15.6834 22.0976 16.3166 21.7071 16.7071L17.4696 20.9446C17.079 21.3351 16.4459 21.3351 16.0553 20.9446C15.6648 20.5541 15.6648 19.9209 16.0553 19.5304L19.5857 16L16.0553 12.4696C15.6648 12.0791 15.6648 11.4459 16.0553 11.0554Z" fill="#181818"/>
                            <path fill-rule="evenodd" clip-rule="evenodd" d="M10 16C10 15.4477 10.4477 15 11 15H21C21.5523 15 22 15.4477 22 16C22 16.5523 21.5523 17 21 17H11C10.4477 17 10 16.5523 10 16Z" fill="#181818"/>
                        </svg>
                    </a>
                </div>
            </div>
        </div>
    </section>
</main>
<?php
get_footer();
?>